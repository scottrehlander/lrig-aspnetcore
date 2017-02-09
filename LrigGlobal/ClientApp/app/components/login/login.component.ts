import { Component } from '@angular/core';
import { Router } from '@angular/router'
import { AuthService } from '../../services/auth.service';

@Component({
    selector: 'login',
    template: require('./login.component.html'),
    styles: [require('./login.component.css')],
    providers: [AuthService]
})

export class LoginComponent {

    credentials: any;
    logo: any;
    errorText: string;

    constructor(private auth: AuthService, private router: Router) {
        this.logo = require('../../../assets/images/LRIG medium bevel.png');
        this.credentials = {
            username: '',
            password: ''
        };
    }

    logout(event) {
        event.preventDefault();
        this.auth.logout();
    }

    onLogin() {
        this.auth.getToken(this.credentials).subscribe(
            data => {
                localStorage.setItem('id_token', data.access_token);
                this.router.navigateByUrl('home');
            },
            error => {
                console.log(error);
                this.errorText = error._body;
            }
        );
    }
}