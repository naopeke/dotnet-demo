import { Observable } from "rxjs";
import { BookService } from "../services/book.service";
import { Actions, Effect } from '@ngrx/effects';
import { Action } from '@ngrx/store';
import * as types from '.action.types';
import * as bookActions from './book.actions';
import { mergeMap, map } from 'rxjs/operators';

export class BookEffects {
    constructor(
        private service: BookService,
        private actions$: Actions
    ){}

    @Effect() loadBooks$: Observable<Action> = this.actions$.pipe(
        ofType<bookActions.loadBooksAction>(types.LOAD_BOOKS),
        mergeMap(()=>
            this.service.getAllBooks().pipe(map(books => new bookActions.loadBooksSuccessAction(books)))
        )
    )
}