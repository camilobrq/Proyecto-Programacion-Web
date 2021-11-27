import { Pipe, PipeTransform } from '@angular/core';
import { Psicologo } from '../Administrador/models/Psicologo';

@Pipe({
  name: 'filtroPsicologo'
})
export class FiltroPsicologoPipe implements PipeTransform {

  transform(empleado: Psicologo[], searchText: string): any {
    if (searchText == null) return empleado;
    return empleado.filter(p =>
      p.identificacion.toLowerCase()
     .indexOf(searchText.toLowerCase()) !== -1);
     
    }

}
