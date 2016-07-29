import { Injectable } from '@angular/core';
import { HTTP_PROVIDERS, Http, Response, Headers, RequestOptions } from "@angular/http";

@Injectable()
export class DiagnosticsService {

  constructor(private http: Http) {}
  getDiagnostics() {
    return this.http.get('http://127.0.0.1:5000/api/Diagnostics').map((res: Response) => res.json());
  }

}