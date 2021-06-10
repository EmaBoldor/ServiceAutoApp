import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Masina } from './masina -models';
//import { Masina } from './masina.models';

@Component({
  selector: 'app-masina',
  templateUrl: './masina.component.html',
  styleUrls: ['./masina.component.css']
})
export class MasinaComponent {

  public masini: Masina[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadMasini();
  }

  public deleteMasina(masina: Masina) {
    this.http.delete(this.baseUrl + 'api/masini/' + masina.id).subscribe(result => {
      this.loadMasini();
    }, error => console.error(error))
  }

  loadMasini() {
    this.http.get<Masina[]>(this.baseUrl + 'api/masini').subscribe(result => {
      this.masini = result;
    }, error => console.error(error));
  }

}
