import os

class Config:
    SQLALCHEMY_DATABASE_URI = 'sqlite:///users.db'  # or your preferred database
    SQLALCHEMY_TRACK_MODIFICATIONS = False
    SECRET_KEY = os.environ.get('SECRET_KEY') or 'your_secret_key_here'
