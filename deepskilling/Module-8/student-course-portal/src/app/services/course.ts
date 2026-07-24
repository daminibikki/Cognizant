import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class Course {

  constructor() { }

  getCourses() {
    return [
      {
        id: 1,
        name: 'Angular',
        code: 'ANG101',
        credits: 4,
        fee: 5000,
        available: true
      },
      {
        id: 2,
        name: 'React',
        code: 'RCT102',
        credits: 3,
        fee: 4500,
        available: false
      },
      {
        id: 3,
        name: 'Java',
        code: 'JAVA201',
        credits: 5,
        fee: 6500,
        available: true
      },
      {
        id: 4,
        name: 'Python',
        code: 'PY301',
        credits: 4,
        fee: 5500,
        available: true
      },
      {
        id: 5,
        name: 'SQL',
        code: 'SQL401',
        credits: 2,
        fee: 3000,
        available: false
      }
    ];
  }

  getCourseCount() {
    return this.getCourses().length;
  }
}