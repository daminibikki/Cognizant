import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Store } from '@ngrx/store';
import * as CourseActions from '../../store/course/course.actions';
import { CourseCard } from '../../components/course-card/course-card';
import { Course } from '../../services/course';

@Component({
  selector: 'app-course-list',
  standalone: true,
  imports: [CommonModule, CourseCard],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList {

  courses: any[] = [];
  courseCount = 0;
  selectedCourseId = 0;

 constructor(
  private courseService: Course,
  private store: Store
) {
  this.courses = this.courseService.getCourses();
  this.courseCount = this.courseService.getCourseCount();

  this.store.dispatch(CourseActions.loadCourses());
}

  onEnroll(id: number): void {
    console.log('Enrolling:', id);
    this.selectedCourseId = id;
  }
}