import { Component } from '@angular/core';

@Component({
    selector: 'home',
    template: require('./home.component.html'),
    styles: [ require('./home.component.css') ]
})
export class HomeComponent {
    largeLogo : string;

    constructor() {
        this.largeLogo = require('../../../assets/images/LRIG medium bevel.png');
    }
}
