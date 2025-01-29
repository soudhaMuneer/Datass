import { Component } from '@angular/core';
import { ChatService } from './chat.service';

@Component({
  selector: 'app-chat',
  template: `
    <div>
      <h2>Chat Application</h2>
      <div id="messages">
        <div *ngFor="let message of chatService.getMessages()">{{ message }}</div>
      </div>
      <input [(ngModel)]="message" placeholder="Type a message" />
      <button (click)="sendMessage()">Send</button>
    </div>
  `,
  styles: []
})
export class ChatComponent {
  message: string = '';

  constructor(public chatService: ChatService) {}

  sendMessage() {
    if (this.message.trim()) {
      this.chatService.addMessage(this.message);
      this.message = '';
    }
  }
}
