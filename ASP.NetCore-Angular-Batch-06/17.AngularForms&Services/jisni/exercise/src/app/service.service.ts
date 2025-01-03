import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServiceService {
  registeredMembers: any[] = [];

  registerMember(member: any) {
    this.registeredMembers.push(member);
  }
  getRegisteredMembers() {
    return this.registeredMembers;
  }
  
}
