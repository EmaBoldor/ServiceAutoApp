import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { Serviciu } from './serviciu -models';

@Component({
  selector: 'app-serviciu-update',
  templateUrl: './serviciu-update.component.html',
  styleUrls: ['./serviciu.component.css']
})
export class ServiciuUpdateComponent  {

  public serviciu: Serviciu;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadServiciu();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadServiciu() {
    this.http.get<Serviciu>(this.baseUrl + 'api/servicii/' + this.param.id).subscribe(result => {
      this.serviciu = result;
    }, error => console.error(error));
  }

  public saveServiciu() {
    this.http.put(this.baseUrl + 'api/servicii/' + this.serviciu.id, this.serviciu).subscribe(result => {
      this.router.navigateByUrl("/servicii");
    }, error => console.error(error));
  }
}


