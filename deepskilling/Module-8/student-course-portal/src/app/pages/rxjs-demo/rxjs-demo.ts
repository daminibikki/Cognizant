import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-rxjs-demo',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './rxjs-demo.html',
  styleUrl: './rxjs-demo.css'
})
export class RxjsDemo {

  message = '';

  constructor() {

    this.getMessage().subscribe(data => {
      this.message = data;
    });

  }

  getMessage(): Observable<string> {

    return of('Welcome to RxJS Observables!');

  }

}