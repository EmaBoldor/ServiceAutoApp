import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { Parteneriat } from './parteneriat -models';


@Component({
  selector: 'app-parteneriat-update',
  templateUrl: './parteneriat-update.component.html',
  styleUrls: ['./parteneriat.component.css']
})
export class ParteneriatUpdateComponent  {

  public parteneriat: Parteneriat;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadParteneriat();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadParteneriat() {
    this.http.get<Parteneriat>(this.baseUrl + 'api/parteneriate/' + this.param.id).subscribe(result => {
      this.parteneriat = result;
    }, error => console.error(error));
  }

  public saveParteneriat() {
    this.http.put(this.baseUrl + 'api/parteneriate/' + this.parteneriat.id, this.parteneriat).subscribe(result => {
      this.router.navigateByUrl("/parteneriate");
    }, error => console.error(error));
  }
}


