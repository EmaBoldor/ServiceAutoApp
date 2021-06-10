import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { Masina } from './masina -models';


@Component({
  selector: 'app-masina-update',
  templateUrl: './masina-update.component.html',
  styleUrls: ['./masina.component.css']
})
export class MasinaUpdateComponent  {

  public masina: Masina;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadMasini();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadMasini() {
    this.http.get<Masina>(this.baseUrl + 'api/masini/' + this.param.id).subscribe(result => {
      this.masina = result;
    }, error => console.error(error));
  }

  public saveMasini() {
    this.http.put(this.baseUrl + 'api/masini/' + this.masina.id, this.masina).subscribe(result => {
      this.router.navigateByUrl("/masini");
    }, error => console.error(error));
  }
}


