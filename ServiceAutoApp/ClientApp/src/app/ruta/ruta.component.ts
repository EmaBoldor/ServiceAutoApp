import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ruta } from './ruta -models';


@Component({
  selector: 'app-ruta',
  templateUrl: './ruta.component.html',
  styleUrls: ['./ruta.component.css']
})
export class RutaComponent {

  public rute: Ruta[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadRute();
  }

  public deleteRuta(ruta: Ruta) {
    this.http.delete(this.baseUrl + 'api/rute/' + ruta.id).subscribe(result => {
      this.loadRute();
    }, error => console.error(error))
  }

  loadRute() {
    this.http.get<Ruta[]>(this.baseUrl + 'api/rute').subscribe(result => {
      this.rute = result;
    }, error => console.error(error));
  }
}
