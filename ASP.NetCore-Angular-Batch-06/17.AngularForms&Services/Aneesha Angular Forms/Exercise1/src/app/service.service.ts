import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FormDataService {
  reactiveForm: any = {};

  constructor() { }

  setFormData(data: any) {
    this.reactiveForm = data;
  }

  getFormData() {
    return this.reactiveForm;
  }
}

