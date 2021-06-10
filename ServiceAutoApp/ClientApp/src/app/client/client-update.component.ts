import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Client } from './client -models';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-client-update',
  templateUrl: './client-update.component.html',
  styleUrls: ['./client.component.css']
})
export class ClientUpdateComponent  {

  public client: Client;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadClienti();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadClienti() {
    this.http.get<Client>(this.baseUrl + 'api/clienti/' + this.param.id).subscribe(result => {
      this.client = result;
    }, error => console.error(error));
  }

  public saveClient() {
    this.http.put(this.baseUrl + 'api/clienti/' + this.client.id, this.client).subscribe(result => {
      this.router.navigateByUrl("/clienti");
    }, error => console.error(error));
  }
}


