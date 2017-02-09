import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions } from '@angular/http';
import 'rxjs/add/operator/map';
import { tokenNotExpired } from 'angular2-jwt';


@Injectable()
export class AuthService {

    constructor(private http: Http) { }

    getToken(credentials) { 
        let token$ = this.http.post('/token', `username=${credentials.username}&password=${credentials.password}`, new RequestOptions({ headers: new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' }) }))
            .map(res => res.json());
        return token$;
    }

    logout() {
        localStorage.removeItem('id_token');
    }

    loggedIn() {
        return tokenNotExpired();
    }
}