import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { FormControl,Validators } from '@angular/forms';
import { FormGroup } from '@angular/forms';
import { CustomValidators } from  '../validators/noSpaceAllowed.Validator';
import {Router} from  "@angular/router";
import { JobdetailsService } from '../jobdetails.service';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit{
   formdata: any={};
   regesteredjob : any[];

       reactiveForm: FormGroup;
      constructor(private router: Router,private JobdetailsService : JobdetailsService){
        
        

      }
       ngOnInit() {
         this.reactiveForm = new FormGroup({
          jobtitle: new FormControl(null, [Validators.required, CustomValidators.noSpaceAllowed]),
          date: new FormControl(null, Validators.required),
          email: new FormControl(null, [Validators.required, Validators.email]),
          location: new FormControl(null, Validators.required)
         })
       }

       OnFormSubmitted(){
        console.log(this.reactiveForm.value);
        this.formdata = this.reactiveForm.value;
        this.JobdetailsService.regesterjob(this.formdata);
        this.regesteredjob = this.JobdetailsService.getregesteredjobs();
        
       }

    send(){
      if(this.reactiveForm && this.reactiveForm.valid){
        this.router.navigate(['/details']);
      }
    }
}


