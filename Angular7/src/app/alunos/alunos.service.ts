import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Aluno } from '../models/Aluno';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AlunosService {

  //Url da API
  private readonly API = 'http://localhost:3000/cursos'

  constructor(private http: HttpClient) { }

  list(){
    return this.http.get<Aluno[]>(this.API)
    .pipe(
      tap(console.log)
    );
  }

  //Executar para ver a difereça do metodo acima
  // list(){
  //   let teste = this.http.get<Aluno[]>(this.API)
  //   console.log(teste);
  // }

}
