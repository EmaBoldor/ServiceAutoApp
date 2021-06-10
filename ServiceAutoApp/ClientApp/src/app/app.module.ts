import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ClientComponent } from './client/client.component';
import { MasinaComponent } from './masina/masina.component';
import { ServiciuComponent } from './serviciu/serviciu.component';
import { RutaComponent } from './ruta/ruta.component';
import { ParteneriatComponent } from './parteneriat/parteneriat.component';
import { ClientAddComponent } from './client/client-add.component';
import { ClientUpdateComponent } from './client/client-update.component';
import { MasinaAddComponent } from './masina/masina-add.component';
import { MasinaUpdateComponent } from './masina/masina-update.component';
import { ParteneriatAddComponent } from './parteneriat/parteneriat-add.component';
import { ParteneriatUpdateComponent } from './parteneriat/parteneriat-update.component';
//import { RutaAddComponent } from './ruta/ruta-add.component';
//import { RutaUpdateComponent } from './ruta/ruta-update.component';
import { ServiciuAddComponent } from './serviciu/serviciu-add.component';
import { ServiciuUpdateComponent } from './serviciu/serviciu-update.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ClientComponent,
    MasinaComponent,
    ServiciuComponent,
    RutaComponent,
    ParteneriatComponent,
    ClientAddComponent,
    ClientUpdateComponent,
    MasinaAddComponent,
    MasinaUpdateComponent,
    ParteneriatAddComponent,
    ParteneriatUpdateComponent,
    //RutaAddComponent,
    //RutaUpdateComponent,
    ServiciuAddComponent,
    ServiciuUpdateComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'clienti', component: ClientComponent },
      { path: 'masini', component: MasinaComponent },
      { path: 'servicii', component: ServiciuComponent },
      { path: 'rute', component: RutaComponent },
      { path: 'parteneriate', component: ParteneriatComponent },
      { path: 'client-add', component: ClientAddComponent },
      { path: 'client-update', component: ClientUpdateComponent },
      { path: 'masina-add', component: MasinaAddComponent },
      { path: 'masina-update', component: MasinaUpdateComponent },
      { path: 'parteneriat-add', component: ParteneriatAddComponent },
      { path: 'parteneriat-update', component: ParteneriatUpdateComponent },
     // { path: 'ruta-add', component: RutaAddComponent },
     // { path: 'ruta-update', component: RutaUpdateComponent },
      { path: 'serviciu-add', component: ServiciuAddComponent },
      { path: 'serviciu-update', component: ServiciuUpdateComponent },
], { relativeLinkResolution: 'legacy' }),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
