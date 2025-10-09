import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ISimpson, Result } from '../../interfaces/ISimpson';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';

@Component({
  selector: 'app-personajes',
  imports: [MatButtonModule, MatCardModule],
  templateUrl: './personajes.html',
  styleUrl: './personajes.scss'
})
export class Personajes implements OnInit {
  http: HttpClient;


  Personajes:Result[] = [];

  constructor(http: HttpClient) {
    this.http = http;
  }

  ngOnInit(): void {
    this.http.get<ISimpson>('https://thesimpsonsapi.com/api/characters')
      .subscribe((data) => {
        this.Personajes = data.results;
      });
  }
}
