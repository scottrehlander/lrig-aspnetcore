import { Injectable } from '@angular/core';

import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';

import { Chapter } from '../models/chapter';

@Injectable()
export class ChaptersService {
    constructor(private http: Http) { }

    getChapters(): Observable<Chapter[]> {
        let chapters$ = this.http.get('/api/Chapters/GetChapters').map(function (response: Response) {
            return response.json();
        });
        return chapters$;
    }
}