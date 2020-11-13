import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AppRoutingModule } from './app-routing.module';
import { TerceroService } from './services/tercero.service';
import { FiltroPagoPipe } from './pipe/filtro-pago.pipe';
import { TerceroRegistroComponent } from './Ayuda/tercero-registro/tercero-registro.component';
import { TerceroConsultaComponent } from './Ayuda/tercero-consulta/tercero-consulta.component';
import { PagoRegistroComponent } from './Ayuda/pago-registro/pago-registro.component';
import { PagoConsultaComponent } from './Ayuda/pago-consulta/pago-consulta.component';
import { HeaderComponent } from './Ayuda/header/header.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    TerceroRegistroComponent,
    TerceroConsultaComponent,
    PagoRegistroComponent,
    PagoConsultaComponent,
    HeaderComponent,
    FiltroPagoPipe
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    AppRoutingModule
  ],
  providers: [TerceroService],
  bootstrap: [AppComponent]
})
export class AppModule { }
