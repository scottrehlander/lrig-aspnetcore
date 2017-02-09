import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
    selector: 'nav-menu',
    template: require('./navmenu.component.html'),
    styles: [require('./navmenu.component.css')],
    providers: [AuthService]
})
export class NavMenuComponent {

    constructor(private auth: AuthService) { }

    logout(event) {
        event.preventDefault();
        this.auth.logout();
    }

}
