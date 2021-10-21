import { Pipe, PipeTransform } from '@angular/core';
import { Persona } from '../Administrador/models/persona';

@Pipe({
  name: 'filtroPaciente'
})
export class FiltroPacientePipe implements PipeTransform {
  
  transform(persona: Persona[], searchText: string): any {
    if (searchText == null) return persona;
    return persona.filter(p =>
      p.nombre.toLowerCase()
     .indexOf(searchText.toLowerCase()) !== -1);
     
    }
    
}
