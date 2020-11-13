import { Component, OnInit } from '@angular/core';
import { Pago } from '../models/Pago';
import { Tercero } from '../models/tercero';
import { TerceroService } from '../../services/tercero.service';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-tercero-registro',
  templateUrl: './tercero-registro.component.html',
  styleUrls: [ './tercero-registro.component.css' ]
})
export class TerceroRegistroComponent implements OnInit {
  tercero: Tercero;
  terceros: Tercero[];
  pago: Pago;
  formGroup: FormGroup;
  constructor(private terceroService: TerceroService, private formBuilder: FormBuilder) { }

  
  ngOnInit() {
    this.tercero = new Tercero();
    this.pago = new Pago();
    formGroup: FormGroup;
    this.buildForm();
  }
  private buildForm() {
    this.tercero.identificacion = '';
    this.tercero.tipoIdentificacion = '';
    this.tercero.nombre = '';
    this.tercero.tipoTercero = '';
    this.tercero.direccion = '';
    this.tercero.telefono = '';
    this.tercero.pais = '';
    this.tercero.departamento = '';
    this.tercero.ciudad = '';
    this.pago.id = 0;
    this.pago.tipoPago = '';
    this.pago.fecha = new Date(Date.now());
    this.pago.valorPago = 0;
    this.pago.valorIva = 0;
    this.formGroup = this.formBuilder.group({
      identificacion: [this.tercero.identificacion, Validators.required],
      tipoIdentificacion: [this.tercero.tipoIdentificacion, Validators.required],
      nombre: [this.tercero.nombre, Validators.required],
      tipoTercero: [this.tercero.tipoTercero, Validators.required],
      direccion: [this.tercero.direccion, Validators.required],
      telefono: [this.tercero.telefono, Validators.required],
      pais: [this.tercero.pais, Validators.required],
      departamento: [this.tercero.departamento, [Validators.required, Validators.min(1)]],
      ciudad: [this.tercero.ciudad, [Validators.required, Validators.min(1)]],
      id: [this.pago.id, Validators.required],
      tipoPago: [this.pago.tipoPago, Validators.required],
      fecha: [this.pago.fecha, Validators.required],
      valorPago: [this.pago.valorPago, Validators.required],
      valorIva: [this.pago.valorIva, Validators.required]

    });

  }

  onSubmit() {

    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }


  add() {
    this.tercero = this.formGroup.value;
    //this.pago.id = this.formGroup.value.codPago;
    //this.pago.tipoPago = this.formGroup.value.tipoPago;

    //this.pago.fecha = this.formGroup.value.fechaPago;
    //this.pago.valorPago = this.formGroup.value.valorPago;
    //this.pago.valorIva = this.formGroup.value.valorIvaPago;

    //this.tercero.pago = this.pago;

    this.terceroService.post(this.tercero).subscribe(p => {
      if (p != null) {
        alert('creado');
        this.tercero = p;
      }
    });
  }

  get control() {
    return this.formGroup.controls;
  }

}
