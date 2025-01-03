import { Component } from '@angular/core';

@Component({
  selector: 'app-new-registrations',
  templateUrl: './new-registrations.component.html',
  styleUrls: ['./new-registrations.component.css']
})
export class NewRegistrationsComponent {
  filterStatus: string = 'All'; // Default filter status
  tableData: any[] = [
    // Table data goes here...
    {
      id : "#APL-0003",
      date : "June 1, 2020, 08:22 AM",
      companyLogo: '../../assets/images/companyLogo.png',
      companyName : "Mosciski Inc.",
      jobtitle : "Creative Design Agency",
      type : "FREELANCE",
      position : "Intern UI Designer",
      contactPhone: '../../assets/images/contact.png',
      contactMail : "../../assets/images/email.png",
      status : 'Pending',
      threedots : "../../assets/images/Frame 2.png"
    },
    {
      id : "#APL-0003",
      date : "June 1, 2020, 08:22 AM",
      companyLogo: '../../assets/images/companyLogo.png',
      companyName : "Mosciski Inc.",
      jobtitle : "Creative Design Agency",
      type : "FREELANCE",
      position : "Intern UI Designer",
      contactPhone: '../../assets/images/contact.png',
      contactMail : "../../assets/images/email.png",
      status : 'On-Hold',
      threedots : "../../assets/images/Frame 2.png"
    },
    {
      id : "#APL-0003",
      date : "June 1, 2020, 08:22 AM",
      companyLogo: '../../assets/images/companyLogo.png',
      companyName : "Mosciski Inc.",
      jobtitle : "Creative Design Agency",
      type : "FREELANCE",
      position : "Intern UI Designer",
      contactPhone: '../../assets/images/contact.png',
      contactMail : "../../assets/images/email.png",
      status : 'Pending',
      threedots : "../../assets/images/Frame 2.png"
    },
    {
      id : "#APL-0003",
      date : "June 1, 2020, 08:22 AM",
      companyLogo: '../../assets/images/companyLogo.png',
      companyName : "Mosciski Inc.",
      jobtitle : "Creative Design Agency",
      type : "FREELANCE",
      position : "Intern UI Designer",
      contactPhone: '../../assets/images/contact.png',
      contactMail : "../../assets/images/email.png",
      status : 'Candidate',
      threedots : "../../assets/images/Frame 2.png"
    },
    {
      id : "#APL-0003",
      date : "June 1, 2020, 08:22 AM",
      companyLogo: '../../assets/images/companyLogo.png',
      companyName : "Mosciski Inc.",
      jobtitle : "Creative Design Agency",
      type : "FREELANCE",
      position : "Intern UI Designer",
      contactPhone: '../../assets/images/contact.png',
      contactMail : "../../assets/images/email.png",
      status : 'On-Hold',
      threedots : "../../assets/images/Frame 2.png"
    },
    {
      id : "#APL-0003",
      date : "June 1, 2020, 08:22 AM",
      companyLogo: '../../assets/images/companyLogo.png',
      companyName : "Mosciski Inc.",
      jobtitle : "Creative Design Agency",
      type : "FREELANCE",
      position : "Intern UI Designer",
      contactPhone: '../../assets/images/contact.png',
      contactMail : "../../assets/images/email.png",
      status : 'Candidate',
      threedots : "../../assets/images/Frame 2.png"
    }
  ];

  filterTableData(status: string): void {
    this.filterStatus = status;
  }

  getFilteredTableData(): any[] {
    if (this.filterStatus === 'All') {
      return this.tableData;
    } else {
      return this.tableData.filter(item => item.status.toLowerCase() === this.filterStatus.toLowerCase());
    }
  }

}
