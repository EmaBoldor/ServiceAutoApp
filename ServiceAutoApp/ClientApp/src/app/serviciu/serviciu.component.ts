import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Serviciu } from './serviciu -models';


@Component({
  selector: 'app-serviciu',
  templateUrl: './serviciu.component.html',
  styleUrls: ['./serviciu.component.css']
})
export class ServiciuComponent {

  public servicii: Serviciu[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadServicii();
  }

  public deleteServiciu(serviciu: Serviciu) {
    this.http.delete(this.baseUrl + 'api/servicii/' + serviciu.id).subscribe(result => {
      this.loadServicii();
    }, error => console.error(error))
  }

  loadServicii() {
    this.http.get<Serviciu[]>(this.baseUrl + 'api/servicii').subscribe(result => {
      this.servicii = result;
    }, error => console.error(error));
  }
}


