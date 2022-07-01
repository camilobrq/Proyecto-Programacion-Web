import { Pipe, PipeTransform } from '@angular/core';
import { Enfermedad } from '../Administrador/models/Enfermedad';

@Pipe({
  name: 'filtroPersona'
})
export class FiltroPersonaPipe implements PipeTransform {

  transform(enfermedad: Enfermedad[], searchText: string): any {
    if (searchText == null) return enfermedad;
    return enfermedad.filter(p =>
      p.descripcion_3.toLowerCase()
     .indexOf(searchText.toLowerCase()) !== -1);
     
    }
}
