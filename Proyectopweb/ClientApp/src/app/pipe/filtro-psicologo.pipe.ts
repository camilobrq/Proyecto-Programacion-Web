import { Pipe, PipeTransform } from '@angular/core';
import { Empleado } from '../Administrador/models/empleado';

@Pipe({
  name: 'filtroPsicologo'
})
export class FiltroPsicologoPipe implements PipeTransform {

  transform(empleado: Empleado[], searchText: string): any {
    if (searchText == null) return empleado;
    return empleado.filter(p =>
      p.identificacion.toLowerCase()
     .indexOf(searchText.toLowerCase()) !== -1);
     
    }

}
