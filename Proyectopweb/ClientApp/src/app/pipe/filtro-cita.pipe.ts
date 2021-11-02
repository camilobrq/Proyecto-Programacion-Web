import { Pipe, PipeTransform } from '@angular/core';
import { Cita } from '../Administrador/models/Cita';

@Pipe({
  name: 'filtroCita'
})
export class FiltroCitaPipe implements PipeTransform {

  transform(cita: Cita[], searchText: string): any {
    if (searchText == null) return cita;
    return cita.filter(p =>
      p.tiposSolicitud.toLowerCase()
     .indexOf(searchText.toLowerCase()) !== -1);
     
    }
}
