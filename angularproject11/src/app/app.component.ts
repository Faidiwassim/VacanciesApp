import { Component } from '@angular/core';
import { TestserviceService } from './testservice.service'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angularproject11';
  isAuth=false;
  appareilOne="relais";
  newdata:any;

  constructor(private _apiService:TestserviceService){}
  
  ngOnInit()
  {
    this._apiService.getData().subscribe(res=>{this.newdata=res;})
  }



  toutAllumer(){
 //console.log("cha3el asbaa");
return "je suis allumé";

  }
}
