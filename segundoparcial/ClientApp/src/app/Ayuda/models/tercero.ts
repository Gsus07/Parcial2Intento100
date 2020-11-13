import { Pago } from "./pago";

export class Tercero {
  constructor() {
    this.pago = new Pago();
  }
  identificacion: string;
  tipoIdentificacion: string;
  nombre: string;
  tipoTercero: string;
  direccion: string;
  telefono: string;
  pais: string;
  departamento: string;
  ciudad: string;
  pago: Pago;
}
