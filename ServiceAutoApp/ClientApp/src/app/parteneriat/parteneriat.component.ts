import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Parteneriat } from './parteneriat -models';



@Component({
  selector: 'app-parteneriat',
  templateUrl: './parteneriat.component.html',
  styleUrls: ['./parteneriat.component.css']
})
export class ParteneriatComponent {

  public parteneriate: Parteneriat[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadParteneriate();
  }

  public deleteParteneriat(parteneriat: Parteneriat) {
    this.http.delete(this.baseUrl + 'api/parteneriate/' + parteneriat.id).subscribe(result => {
      this.loadParteneriate();
    }, error => console.error(error))
  }

  loadParteneriate() {
    this.http.get<Parteneriat[]>(this.baseUrl + 'api/parteneriate').subscribe(result => {
      this.parteneriate = result;
    }, error => console.error(error));
  }
}

