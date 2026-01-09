import { Component, HostListener } from '@angular/core';

export interface HeaderItem {
  label: string;
  path: string;
}
@Component({
  selector: 'app-header',
  standalone: false,
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})


export class HeaderComponent {
  isSticky = false;
  isSignInOpen = false;
  isSignUpOpen = false;
  navbarOpen = false;

  @HostListener('window:scroll', [])
  onScroll() {
    this.isSticky = window.pageYOffset > 50;
  }

  headerData: HeaderItem[] = [
    {
      label: 'Home', path: '/home'       
    },
    {
      label: 'Courses', path: '/courses'
    },
    {
      label: 'About Us', path: '/about-us'
    }   
  ]

  openSignIn() {
    this.isSignInOpen = true; 
  }

  closeSignIn() {
    this.isSignInOpen = false;
  }

  openSignUp() {
    this.isSignUpOpen = true;
  }

  closeSignUp() {
    this.isSignUpOpen = false;
  }

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
}
