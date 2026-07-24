import { Component } from '@angular/core';
import { ReactiveFormsModule, FormGroup, FormControl, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-student-registration',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './student-registration.html',
  styleUrl: './student-registration.css'
})
export class StudentRegistration {

  studentForm = new FormGroup({
    name: new FormControl('', [
      Validators.required,
      Validators.minLength(3)
    ]),

    email: new FormControl('', [
      Validators.required,
      Validators.email
    ]),

    age: new FormControl('', [
      Validators.required,
      Validators.min(18)
    ]),

    course: new FormControl('', [
      Validators.required
    ])
  });

  onSubmit() {

    if (this.studentForm.valid) {

      alert('Registration Successful');

      console.log(this.studentForm.value);

    }

  }

}