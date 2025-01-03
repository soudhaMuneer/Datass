import { Component } from '@angular/core';
import { JobClass } from './job';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  filteredCompany:JobClass[]=[];
 
  arry:JobClass[]=[];
job: any;
  constructor(){
    this.arry =[{
    designation:"UI/UX Designer",
    companyLogo:"assets/image/Rectangle 14 (2) - Copy.png" ,
    compantName:"Shopee",
    text_1:"Fulltime",
    text_2:"Midlevel",
    text_3:"$3000-$5000", 
    text_4:"Indonesia",
    text_5:"Save",
    text_6:"Remove",
  },
  {
    designation:"Product Designer",
    companyLogo:"assets/image/amazon.png",
    compantName:"google",
    text_1:"Fulltime",
    text_2:"Midlevel",
    text_3:"$3000-$5000", 
    text_4:"Indonesia",
    text_5:"Save",
    text_6:"Remove",
  },
  {
    designation:"UX Designer",
    companyLogo:"assets/image/Rectangle 14 (2).png",
    compantName:"Ebay",
    text_1:"Fulltime",
    text_2:"Midlevel",
    text_3:"$3000-$5000", 
    text_4:"Indonesia",
    text_5:"Save",
    text_6:"Remove",
  },
  {
    designation:"Software Engineer",
    companyLogo:"assets/image/Rectangle 14.png",
    compantName:"Tech Solutions Inc.",
    text_1:"Fulltime",
    text_2:"Midlevel",
    text_3:"$3000-$5000", 
    text_4:"Indonesia",
    text_5:"Save",
    text_6:"Remove",
  },
  {
    designation:"Marketing Manager",
    companyLogo:"assets/image/Rectangle 14 (1).png",
    compantName:"Global Marketing Agency",
    text_1:"Fulltime",
    text_2:"Midlevel",
    text_3:"$3000-$5000", 
    text_4:"Indonesia",
    text_5:"Save",
    text_6:"Remove",
  },

  ]
  this.filteredCompany=this.arry
}
filterJob(event: Event): void {
  const searchTerm = (event.target as HTMLInputElement).value;
  this.filteredCompany = this.arry.filter(searchjob =>
    searchjob.designation.toLowerCase().includes(searchTerm.toLowerCase()) ||
    searchjob.compantName.toLowerCase().includes(searchTerm.toLowerCase())
  );
  
  
}
  
  arry1:JobClass[]=[]
  button:boolean=false
  saveFun( para:JobClass){
    this.button=true
    this.arry1.push(para)
   
    

  }


  clicked:boolean=false;
  savedJobs(job:any){
    this.clicked=true;
  

  }

  listJobs(){
    this.clicked=false;

  

  }
}

