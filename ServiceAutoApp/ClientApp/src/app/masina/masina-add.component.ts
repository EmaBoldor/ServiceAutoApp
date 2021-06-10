import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Masina } from './masina -models';


@Component({
  selector: 'app-masina-add',
  templateUrl: './masina-add.component.html',
  styleUrls: ['./masina.component.css']
})
export class MasinaAddComponent  {

  public masina: Masina ;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.masina = <Masina>{}; }

  public saveMasina() {
    this.http.post(this.baseUrl + 'api/masini', this.masina).subscribe(result => {
      this.router.navigateByUrl("/masini");
    }, error => console.error(error))
  }

}


