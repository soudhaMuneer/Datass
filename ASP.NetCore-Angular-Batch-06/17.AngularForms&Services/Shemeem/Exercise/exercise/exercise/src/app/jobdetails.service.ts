import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JobdetailsService {
  registeredjob: any[] = [];
  regesterjob(job:any){
    this.registeredjob.push(job);
    console.log(this.registeredjob);
  }

  getregesteredjobs(){
    return this.registeredjob;
  }

  constructor() { }
}
