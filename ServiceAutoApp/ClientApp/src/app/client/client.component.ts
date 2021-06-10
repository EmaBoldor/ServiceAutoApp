import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Client } from './client -models';


@Component({
  selector: 'app-client',
  templateUrl: './client.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientComponent  {

  public clienti: Client[];

  //columnsToDisplay: string[] = ['nume', 'prenume', 'locatia', 'tipDefectiune', 'tipMasina'];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadClienti();
  }

  public deleteClient(client: Client) {
    this.http.delete(this.baseUrl + 'api/clienti/' + client.id).subscribe(result => {
      this.loadClienti();
    }, error => console.error(error))
  }

  loadClienti() {
    this.http.get<Client[]>(this.baseUrl + 'api/clienti').subscribe(result => {
      this.clienti = result;
    }, error => console.error(error));
  }
}


