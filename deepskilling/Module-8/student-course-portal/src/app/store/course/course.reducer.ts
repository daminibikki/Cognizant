import { createReducer, on } from '@ngrx/store';
import * as CourseActions from './course.actions';
import { initialState } from './course.state';

export const courseReducer = createReducer(
  initialState,

  on(CourseActions.loadCourses, (state) => ({
    ...state,
    loading: true
  })),

  on(CourseActions.loadCoursesSuccess, (state, action) => ({
    ...state,
    loading: false,
    courses: action.courses
  }))
);