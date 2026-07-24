import { Routes } from '@angular/router';
import { StudentRegistration } from './pages/student-registration/student-registration';
import { Home } from './pages/home/home';
import { CourseList } from './pages/course-list/course-list';
import { StudentProfile } from './pages/student-profile/student-profile';
import { UserList } from './pages/user-list/user-list';
import { NotFound } from './pages/not-found/not-found';
import { RxjsDemo } from './pages/rxjs-demo/rxjs-demo';
export const routes: Routes = [
  {
    path: '',
    component: Home
  },
  {
  path: 'register',
  component: StudentRegistration
},
{
  path: 'rxjs',
  component: RxjsDemo
},
  {
    path: 'courses',
    component: CourseList
  },
  {
    path: 'profile',
    component: StudentProfile
  },
  {
    path: 'users',
    component: UserList
  },
  {
    path: '**',
    component: NotFound
  }
];