export interface CourseState {
  courses: any[];
  loading: boolean;
}

export const initialState: CourseState = {
  courses: [],
  loading: false
};