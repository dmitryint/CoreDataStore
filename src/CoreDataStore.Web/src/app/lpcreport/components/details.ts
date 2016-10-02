import { Component, ViewContainerRef, ViewEncapsulation, OnInit, OnDestroy } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
// import { PAGINATION_DIRECTIVES } from 'ng2-bootstrap/ng2-bootstrap';
// import { Overlay } from 'angular2-modal';
// import { Modal } from 'angular2-modal/plugins/bootstrap';

import { DetailsListComponent } from './detailsList';
import { LandmarksListComponent } from './landmarksList';
import { LPCReportService } from '../services/lpcreport';
import { IProperty } from '../../interfaces';

@Component({
  selector: 'properties-details',
  templateUrl: 'app/lpcreport/components/details.html',
  providers: [LPCReportService]
})

export class DetailsComponent implements OnInit, OnDestroy {
  public title: string;
  public details: any = null;
  public landmarkProperties: any = null;
  public sub: any = null;

  /*@Inject(ActivatedRoute) */
  constructor(private lpcReportService: LPCReportService, private location: Location, private route: ActivatedRoute
    /*overlay: Overlay, vcRef: ViewContainerRef, public modal: Modal*/
  ) {
    // overlay.defaultViewContainer = vcRef;
  }

  ngOnInit() {
    this.title = 'Details';

    this.sub = this.route.params.subscribe(params => {
      let id = +params['id'];
      // console.log(id);
      this.lpcReportService.getLPCReport(id).subscribe(
        data => {
          this.details = data;
          this.lpcReportService.getLandmarkProperties(this.details.lpNumber).subscribe(
            data => { this.landmarkProperties = data; },
            () => console.log('done loading getLandmarkProperties')
          );
        }
      );
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  goBack() {
    this.location.back();
  }
}
