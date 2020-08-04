import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-developer',
  templateUrl: './developer.component.html',
  styleUrls: ['./developer.component.css']
})
export class DeveloperComponent implements OnInit {
  developers: any;

  // tslint:disable-next-line: deprecation
  constructor(private http: Http) { }

  ngOnInit() {
    this.getDevelopers();
  }

  getDevelopers() {
    this.http.get('http://localhost:5000/api/developers').subscribe(response => {
      this.developers = response.json();
    });
  }

}
