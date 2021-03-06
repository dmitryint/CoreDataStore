### Docker 

##### Local - (Build container)

````
 docker-compose --file docker-compose-local.yml  build 
 docker-compose --file docker-compose-local.yml  up
````

##### Development - (Lattest Tag)
````
 docker-compose --file docker-compose-development.yml  up
````

##### Staging - (Stable Tag)
````
 docker-compose --file docker-compose-staging.yml  up
````

##Usefull Commands 

###Images 

```bash 
    docker images                     #Get List of Images
    docker rmi  -f <IMAGEID>          #Remove Image 
```

###Containers 

```bash 
    docker ps -a                    #All Containers
    docker ps                       #Running Containers 
    docker stop <CONATINERID>       #Stop Running Container
    docker rm  -f <CONATINERID>     #Remove Container
```

###Publish

```bash 
docker tag coredatastore stuartshay/coredatastore
docker push stuartshay/coredatastore:latest
```

###Run 

```bash 
   docker pull stuartshay/coredatastore
   docker run --rm --name <containername> -p 5000:5000 stuartshay/coredatastore
```

###Volumes 

```bash 
   docker volume ls
   docker volume rm <VOLUMENAME>
```

##Examine Containers

```bash 
# Get Created DateTime  
docker inspect -f '{{ .Created }}' stuartshay/coredatastore
docker logs <CONATINERID>
```

```bash 
# Examine Filesystem (bash shell)
docker run -i -t --entrypoint /bin/bash <IMAGEID>  
```



