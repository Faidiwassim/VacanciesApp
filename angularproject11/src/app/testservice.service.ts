import {HttpClient} from '@angular/common/http'
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TestserviceService {

  constructor(private _http:HttpClient) { }


  getData(){
    return this._http.get('https://localhost:7258/api/Employee/GetVacancyDays/80b56f48-4096-4e64-927c-dd75b3629fea');
           }
}
