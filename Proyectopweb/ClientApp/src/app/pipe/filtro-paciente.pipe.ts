import { Pipe, PipeTransform } from '@angular/core';
import { Paciente } from '../Administrador/models/Paciente';

@Pipe({
  name: 'filtroPaciente'
})
export class FiltroPacientePipe implements PipeTransform {
  
  transform(persona: Paciente[], searchText: string): any {
    if (searchText == null) return persona;
    return persona.filter(p =>
      p.nombre.toLowerCase()
     .indexOf(searchText.toLowerCase()) !== -1);
     
    }
    
}
