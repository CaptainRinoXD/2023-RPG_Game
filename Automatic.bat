git add .
git commit -m "automatic commit"
git push
urxvt -e tmux new-session sh -c 'top; "$SHELL"'