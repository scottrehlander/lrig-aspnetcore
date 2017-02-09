import { Injectable } from '@angular/core';

import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';

import { Event } from '../models/event';

@Injectable()
export class EventsService {
    constructor(private http: Http) { }

    getEvents(): Observable<Event[]> {
        let events$ = this.http.get('/api/Events/GetEvents').map(function (response: Response) {
            return response.json();
        });
        return events$;
    } 
}