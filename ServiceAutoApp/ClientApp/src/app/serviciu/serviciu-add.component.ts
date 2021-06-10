import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Serviciu } from './serviciu -models';


@Component({
  selector: 'app-serviciu-add',
  templateUrl: './serviciu-add.component.html',
  styleUrls: ['./serviciu.component.css']
})
export class ServiciuAddComponent  {

  public serviciu: Serviciu ;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.serviciu = <Serviciu>{}; }

  public saveServiciu() {
    this.http.post(this.baseUrl + 'api/servicii', this.serviciu).subscribe(result => {
      this.router.navigateByUrl("/servicii");
    }, error => console.error(error))
  }

}


