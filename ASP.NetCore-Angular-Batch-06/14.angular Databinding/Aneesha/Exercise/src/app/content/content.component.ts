import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
    Details=[
      {
        image:'../../assets/pexels-cottonbro-studio-4098157.jpg',
        name:'Alen',
        education:'MCA',
        experiance:'3 years',
        place:'Bangalore'
      },

      {
        image:'../../assets/pexels-cottonbro-studio-4098157.jpg',
        name:'sarah',
        education:'MSA',
        experiance:'3 years',
        place:'Chennai'
      },

      {
        image:'../../assets/pexels-cottonbro-studio-4098157.jpg',
        name:'Vivek',
        education:'BTECH',
        experiance:'3 years',
        place:'UK'
      },

      {
        image:'../../assets/pexels-cottonbro-studio-4098157.jpg',
        name:'Deepa',
        education:'MCA',
        experiance:'3 years',
        place:'Bangalore'
      }
    ]
}
