import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IInvoice } from 'src/interfaces/invoice';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'crud-client';
  baseUrl = "https://localhost:6001/";  
  invList: any;


  constructor(private httpClient: HttpClient) {

  }
  ngOnInit(): void {
    this.getAllInvoices();
  }

  getAllInvoices() {
    this.httpClient.get(this.baseUrl+'crud').subscribe(  //Enabled CORS in Webapi for this URL
      (response) => {
        console.log(response);
        this.invList = response;
      },
      error => {
        console.log(error);
      })
  }

}
