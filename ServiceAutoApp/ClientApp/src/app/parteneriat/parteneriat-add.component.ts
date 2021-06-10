import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Parteneriat } from './parteneriat -models';


@Component({
  selector: 'app-parteneriat-add',
  templateUrl: './parteneriat-add.component.html',
  styleUrls: ['./parteneriat.component.css']
})
export class ParteneriatAddComponent  {

  public parteneriat: Parteneriat ;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.parteneriat = <Parteneriat>{}; }

  public saveParteneriat() {
    this.http.post(this.baseUrl + 'api/parteneriate', this.parteneriat).subscribe(result => {
      this.router.navigateByUrl("/parteneriate");
    }, error => console.error(error))
  }

}


