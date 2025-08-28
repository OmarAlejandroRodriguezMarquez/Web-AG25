import { Component } from '@angular/core';

@Component({
  selector: 'app-hello',
  imports: [],
  templateUrl: './hello.html',
  styleUrl: './hello.css'
})
export class Hello {
  nombre:string="Pedro";
  resultado:number=0;
  animales:string[]=["Perro","Gato","Loro"];

  suma(a:number,b:number):number{
    this.resultado = a+b;
    console.log(this.resultado);
    return this.resultado;
  }

  datos(){
    let nombre = "Ana";
    nombre = 20;

    let edad:number;
    edad = 30;
    edad = "treinta";

    let loqueSea:any = "cualquier cosa";
    loqueSea = 100;
    loqueSea = true;
    loqueSea = {};
    loqueSea = 5.54;

    let nolose:undefined

    let mezcla:number | string = 30;
    mezcla = "bebé";
    mezcla = true;

    let mezcla2:number | "bebé" ;
    mezcla2 = 300;
    mezcla2 = "bebé";
    mezcla2 = "baby";
    mezcla2 = true;
  }
}
