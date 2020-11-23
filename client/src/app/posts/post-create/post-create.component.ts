import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-post-create',
  templateUrl: './post-create.component.html'
})

export class PostCreateComponent implements OnInit {
  ttitle = 'Q-Less Transport Card';
  qltcs: any;

  constructor(private http: HttpClient) {}

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getQLTC();
  }

  // tslint:disable-next-line: typedef
  getQLTC() {
    this.http.get('https://localhost:5001/api/QLTCs').subscribe(response => {
      this.qltcs = response;
    }, error => {
      console.log(error);
    });
  }


}

