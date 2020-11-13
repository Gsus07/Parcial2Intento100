import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { TerceroRegistroComponent } from './Ayuda/tercero-registro/tercero-registro.component';
import { TerceroConsultaComponent } from './Ayuda/tercero-consulta/tercero-consulta.component';
import { PagoRegistroComponent } from './Ayuda/pago-registro/pago-registro.component';
import { PagoConsultaComponent } from './Ayuda/pago-consulta/pago-consulta.component';

const routes: Routes = [
  {
  path: 'ConsultaTercero',
  component: TerceroConsultaComponent
  },
  {
  path: 'RegistroTercero',
  component: TerceroRegistroComponent
  },
  {
  path: 'pagoRegistro',
  component: PagoRegistroComponent
  },
  {
  path: 'pagoConsulta',
  component: PagoConsultaComponent
  }
  ];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
