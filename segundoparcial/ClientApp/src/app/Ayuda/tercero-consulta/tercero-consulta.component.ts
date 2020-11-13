
import { TerceroService } from 'src/app/services/tercero.service';
import { Tercero } from '../models/tercero';
import { OnInit, Component } from '@angular/core';

@Component({
  selector: 'app-tercero-consulta',
  templateUrl: './tercero-consulta.component.html',
  styleUrls: ['./tercero-consulta.component.css']
})
export class TerceroConsultaComponent implements OnInit {
  terceros: Tercero[];
  searchText: string;

  constructor(private terceroService: TerceroService) { }

  ngOnInit(): void {
    this.get();
  }

  get() {
    this.terceroService.get().subscribe(result => {
      this.terceros = result;
    });
  }

}
