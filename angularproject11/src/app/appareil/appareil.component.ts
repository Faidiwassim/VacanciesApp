import {Component,Input,OnInit } from '@angular/core';


@Component({
  selector: 'app-appareil',
  templateUrl: './appareil.component.html',
  styleUrls: ['./appareil.component.css']
})
export class AppareilComponent {
//appareilName='machine à laver';
constructor(){}


  @Input()appareilName!: String;
  appareilStatus='éteint';
  nb=0;


/*getStatus()
{
return this.appareilStatus;
}
*/
}


