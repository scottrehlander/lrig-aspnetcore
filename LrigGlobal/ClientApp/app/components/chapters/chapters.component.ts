import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

import { ChaptersService } from '../../services/chapters.service';

@Component({
    selector: 'chapters',
    template: require('./chapters.component.html'),
    styles: [ require('./chapters.component.css') ],
    providers: [ ChaptersService ]
})

export class ChaptersComponent implements OnInit {

    public chapters;

    constructor(private chaptersService: ChaptersService) { }

    ngOnInit(): void {
        this.chaptersService.getChapters().subscribe(result => this.chapters = result);
    }

}