import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

import { EventsService } from '../../services/events.service';

@Component({
    selector: 'events',
    template: require('./events.component.html'),
    providers: [EventsService]
})

export class EventsComponent implements OnInit {

    constructor(private eventsService: EventsService) { }

    ngOnInit(): void {
        this.eventsService.getEvents().subscribe(result => this.events = result);
    }

    public events;
   
}
